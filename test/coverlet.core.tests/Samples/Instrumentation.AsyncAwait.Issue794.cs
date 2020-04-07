// Remember to use full name because adding new using directives change line numbers

using System.Threading.Tasks;

namespace Coverlet.Core.Samples.Tests
{
    public class AsyncAwait_Issue794
    {
        public async Task<int> TestAsync(int num)
        {
            await Task.Delay(0);
            return num;
        }

        private void ThisMethodIsNotUsed()
        {
            // But must be here to generate coverage for this class at all
        }
    }
}
