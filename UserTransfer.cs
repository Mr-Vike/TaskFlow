using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFlow
{
    public class UserTransfer
    {
        public event EventHandler TransferComplete;

        public  void OnTransferComplete(EventArgs e)
        {
            TransferComplete?.Invoke(this, e);
        }
    }

    public delegate void TransferCompleteEventHandler(object sender, TransferCompleteEventArgs e);

    public class TransferCompleteEventArgs : EventArgs
    {
        public DateTime StartedAt { get; set; }
        public DateTime EndedAt { get; set; }
        public double Progress { get; set; }
    }
}
