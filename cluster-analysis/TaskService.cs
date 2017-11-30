using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMPI7
{
    public class TaskService
    {

        public int[][] initialMatrix;
        public double[][] distanceMatrix;
        public int clustersBound;
        public int parametersBound;
        public List<double[][]> snapMatrix = new List<double[][]>();
        public List<List<List<double>>> snaps = new List<List<List<double>>>();
        public bool toMax = true;
        public bool isEuclidDistanceUsual = true;

        public void GetDistanceMatrix()
        {
            distanceMatrix = new double[initialMatrix[0].Length][];
            for(int i = 0; i < initialMatrix[0].Length; i++)
            {
                distanceMatrix[i] = new double[initialMatrix[0].Length];
                for(int j = 0; j < initialMatrix[0].Length; j++)
                {
                    distanceMatrix[i][j] = Math.Sqrt(GetSumForEuclid(i,j));
                }
            }

        }

        public double GetVariance(int [] array)
        {
            double sum = 0;

            double mean = GetSampleMean(array);

            for (int i = 0; i < array.Length; i++)
            {
                sum += (array[i] - mean) * (array[i] - mean);
            }

            return Math.Round(sum / array.Length, 2);
        }

        public double GetSampleMean(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum / array.Length;
        }

        double GetSumForEuclid(int i, int j)
        {
            double sum = 0;
            for(int k = 0; k < initialMatrix.Length; k++)
            {
                sum += isEuclidDistanceUsual ? Math.Pow((initialMatrix[k][i] - initialMatrix[k][j]), 2) : Math.Pow((initialMatrix[k][i] - initialMatrix[k][j]), 2) / GetVariance(initialMatrix[k]);
            }
            return sum;
        }

        public List<List<List<double>>> Run()
        {
            
            List<List<double>> clusters = new List<List<double>>();
            for(int i = 1; i <= distanceMatrix.Length; i++)
            {
                List<double> newCluster = new List<double>();
                newCluster.Add(i);
                clusters.Add(newCluster);
            }
            snaps.Add(GetCopy(clusters));

            while(clusters.Count != 1)
            {
                Tuple<int, int> currentMax = Get(toMax);

                if (parametersBound > 0)
                {
                    if (parametersBound > distanceMatrix[currentMax.Item1][currentMax.Item2])
                    {
                        break;
                    }
                }

                List<double> cluster = clusters[currentMax.Item1];
                List<double> clusterToAdd = clusters[currentMax.Item2];
                cluster.AddRange(clusterToAdd);
                clusters.Remove(clusterToAdd);
                snaps.Add(GetCopy(clusters));
                snapMatrix.Add(GetCopy(distanceMatrix));
                Remove(currentMax.Item2, currentMax.Item2);

                if (clustersBound > 0)
                {
                    if (clustersBound == clusters.Count)
                    {
                        break;
                    }
                }
            }

            return snaps;
        }



        public double[][] GetCopy(double[][] m)
        {
            double[][] newM = new double[m.Length][];
            
            for(int i = 0; i < m.Length; i++)
            {
                newM[i] = new double[m[i].Length];
                m[i].CopyTo(newM[i],0);
            }

            return newM;
        }

        public List<List<double>> GetCopy(List<List<double>> cl)
        {
            List<List<double>> newCl = new List<List<double>>();
            for (int i = 0; i < cl.Count; i++)
            {
                newCl.Add(new List<double>());
                for (int j = 0; j < cl[i].Count; j++)
                {
                    newCl[i].Add(cl[i][j]);
                }
            }
            return newCl;
        }
        Tuple<int, int> Get(bool max)
        {
            Tuple<int, int> extr = new Tuple<int, int>(-1,-1);
            for (int i = 0; i < distanceMatrix.Length; i++)
            {
                for (int j = 0; j < distanceMatrix[i].Length; j++)
                {
                    if (i != j)
                    {
                        if (extr.Item1 == -1)
                        {
                            extr = new Tuple<int, int>(i, j);
                        } else
                        {
                            if (max)
                            {
                                if (distanceMatrix[i][j] > distanceMatrix[extr.Item1][extr.Item2])
                                {
                                    extr = new Tuple<int, int>(i, j);
                                }
                            }
                            else
                            {
                                if (distanceMatrix[i][j] < distanceMatrix[extr.Item1][extr.Item2])
                                {
                                    extr = new Tuple<int, int>(i, j);
                                }
                            }
                        }
                    }
                    
                }

            }
            return extr;
        }

        void Remove(int column, int row)
        {
            double[][] newMatrix = new double[distanceMatrix.Length - 1][];

            int ii = 0;
            for (int i = ii; i < distanceMatrix.Length; i++)
            {
                if (column != i)
                {
                    newMatrix[ii] = new double[distanceMatrix[i].Length];
                    distanceMatrix[i].CopyTo(newMatrix[ii], 0);
                    ii++;
                }
            }

            for (int j = 0; j < newMatrix[0].Length; j++)
            {
                if (row == j)
                {
                    for (int i = 0; i < newMatrix.Length; i++)
                    {

                        List<double> newColumn = new List<double>();

                        for (int q = 0; q < newMatrix[i].Length; q++)
                        {
                            if (q != j)
                            {
                                newColumn.Add(newMatrix[i][q]);
                            }
                        }

                        newMatrix[i] = newColumn.ToArray();

                    }
                }
            }

            distanceMatrix = newMatrix;
        }

        public string GetStringForClusters(List<List<double>> clusters)
        {
            string output = "";
            for (int i = 0; i < clusters.Count; i++)
            {
                string str = "(";
                List<double> classEq = clusters[i];

                for (int j = 0; j < classEq.Count; j++)
                {
                    double state = classEq[j];
                    str += state;
                    if (j != classEq.Count - 1)
                    {
                        str += ", ";
                    }
                }
                str += ")";
                if (i != clusters.Count - 1)
                {
                    str += ",    ";
                }
                output += str;
            }
            return output;
        }

        public string GetStringForCluster(List<double> cluster)
        {
            string output = "(";
            for (int i = 0; i < cluster.Count; i++)
            {
                output += $"{cluster[i]}";

                if(i < cluster.Count -1)
                {
                    output += ", ";
                }
                
            }
            return output += ")";
        }
    }
}
