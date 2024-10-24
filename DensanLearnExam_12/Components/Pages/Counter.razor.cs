using System.Security.Cryptography;

namespace DensanLearnExam_12.Components.Pages
{
    public partial class Counter
    {
        private int currentCount = 0;
        private int radzenCurrentCount = 0;
        private string radzenCounter = string.Empty;

        private void IncrementCount()
        {
            currentCount++;
        }

        private void DecrementCount()
        {
            currentCount--;
        }

        private void IncrementRadzenCount()
        {
            radzenCurrentCount++;
        }

        private void DecrementRadzenCount()
        {
            radzenCurrentCount--;
        }

        private string DispRadzenCounter()
        {
            return "Radzen Counter count:" + radzenCurrentCount.ToString();
        }

        private string GetColor()
        {
            return currentCount >= 1 && currentCount <= 5  ? "counter-special-color" : "counter-normal-color";
        }

        private string GetRadzenColor()
        {
            return radzenCurrentCount >= 1 && radzenCurrentCount <= 5 ? "counter-special-color" : "counter-normal-color";
        }
    }
}
