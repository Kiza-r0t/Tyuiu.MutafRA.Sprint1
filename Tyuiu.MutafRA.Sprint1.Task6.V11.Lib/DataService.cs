using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MutafRA.Sprint1.TaskX.V11.Lib
{
    public class DataService : ISprint1Task6V11
    {
        public bool CheckeFirstLetterRepetition(string value)
        {
            return !string.IsNullOrEmpty(value) && value.IndexOf(value[0], 1) != -1;
        }
    }
}