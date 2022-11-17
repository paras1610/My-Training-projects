using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_sum_file
{
    public class Sum_File
    {
        public void Savedata(int in1, int in2, int sum)
        {
            StreamWriter writer = new StreamWriter("paras.txt");
            writer.WriteLine($"the sum of {in1} and {in2} is {sum}");
            writer.Close();

        }
    }
}
