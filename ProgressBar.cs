using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFlow
{
    public class ProgressBar
    {
        private int totalProgress;
        private int currentProgress;

        public ProgressBar(int totalProgress)
        {
            this.totalProgress = totalProgress;
            this.currentProgress = 0;
        }

        public void Load(int percentMore)
        {
            currentProgress += percentMore;
            if (currentProgress >= totalProgress)
            {
                ProgressComplete?.Invoke(this, EventArgs.Empty);
            }
        }

        public event EventHandler ProgressComplete;
    }
}
