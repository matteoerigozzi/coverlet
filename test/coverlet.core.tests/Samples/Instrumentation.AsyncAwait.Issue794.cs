// Remember to use full name because adding new using directives change line numbers

using System.Threading.Tasks;

namespace Coverlet.Core.Samples.Tests
{
    public class AsyncAwait_Issue794
    {
        public async Task<int> TestAsync(int num)
        {
            if (num > 50)
            {
                return num;
            }

            try
            {
                await AsyncWait(num);
                return num;
            }
            catch (System.Exception)
            {
                return num;
            }
        }

        private async Task AsyncWait(int iterations)
        {
            await Task.Delay(iterations);
        }
    }
}
