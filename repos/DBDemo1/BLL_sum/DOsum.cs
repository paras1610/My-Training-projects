//Business logic layer
using DAL_sum;
namespace BLL
{
    public class DOsum
    {
        public int DoSum(int fno, int sno)
        {
            int sum = fno + sno;
            DbRepository db = new DbRepository();
            db.Savedata(fno, sno, sum);
            return sum;
        }
    }
}