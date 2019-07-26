using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityEngine
{
    public class DownloadHandler
    {
        internal DownloadHandler m_DownloadHandler;
        public DownloadHandler downloadHandler { 
            get
            {
                return this.m_DownloadHandler;
            }
            set
            {
                /*if (!this.isModifiable)
                    throw new InvalidOperationException("UnityWebRequest has already been sent; cannot modify the download handler");
                UnityWebRequest.UnityWebRequestError err = this.SetDownloadHandler(value);
                if (err != UnityWebRequest.UnityWebRequestError.OK)
                    throw new InvalidOperationException(UnityWebRequest.GetWebErrorString(err));
                    */
                this.m_DownloadHandler = value;
            }
        }

        public string text { get; }
    }
}
