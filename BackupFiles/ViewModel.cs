using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace BackupFiles
{
    public class ViewModel : INotifyPropertyChanged
    {
        private bool isAutoStart;
        public bool IsAutoStart
        {
            get
            {
                return this.isAutoStart;
            }
            set
            {
                this.isAutoStart = value;
                this.Invoke(nameof(this.IsAutoStart));
            }
        }

        private string fromPath;
        public string FromPath
        {
            get
            {
                return this.fromPath;
            }
            set
            {
                this.fromPath = value;
                this.Invoke(nameof(this.FromPath));
            }
        }

        private string toPath;
        public string ToPath
        {
            get
            {
                return this.toPath;
            }
            set
            {
                this.toPath = value;
                this.Invoke(nameof(this.ToPath));
            }
        }

        private string ignoreFileList;
        public string IgnoreFileList
        {
            get
            {
                return this.ignoreFileList;
            }
            set
            {
                this.ignoreFileList = value;
                this.Invoke(nameof(this.IgnoreFileList));
            }
        }

        private string ignorePathList;
        public string IgnorePathList
        {
            get
            {
                return this.ignorePathList;
            }
            set
            {
                this.ignorePathList = value;
                this.Invoke(nameof(this.IgnorePathList));
            }
        }

        private int days;
        public int Days
        {
            get
            {
                return this.days;
            }
            set
            {
                this.days = value;
                this.Invoke(nameof(this.Days));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void Invoke(string propertyName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
