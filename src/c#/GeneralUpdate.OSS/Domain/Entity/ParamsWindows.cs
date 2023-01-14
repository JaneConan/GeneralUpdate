﻿using GeneralUpdate.Core.Bootstrap;

namespace GeneralUpdate.OSS.Domain.Entity
{
    public class ParamsWindows : GeneralUpdate.Core.Domain.Entity.Entity
    {
        public string Url { get; set; }

        public string AppName { get; set; }

        public string CurrentVersion { get; set; }

        public string VersionFileName { get; set; }

        public Action<object , MutiDownloadStatisticsEventArgs> MutiDownloadStatisticsAction { get; set; }

        public Action<object, MutiDownloadProgressChangedEventArgs> MutiDownloadProgressChangedAction { get; set; }

        public Action<object, MutiDownloadCompletedEventArgs> MutiDownloadCompletedAction { get; set; }

        public Action<object, MutiAllDownloadCompletedEventArgs> MutiAllDownloadCompletedAction { get; set; }

        public Action<object, MutiDownloadErrorEventArgs> MutiDownloadErrorAction { get; set; }

        public Action<object, ExceptionEventArgs> ExceptionEventAction { get; set; }

        public ParamsWindows(string url, string appName, string currentVersion, string versionFileName, 
            Action<object, MutiDownloadStatisticsEventArgs> mutiDownloadStatistics= null, 
            Action<object, MutiDownloadProgressChangedEventArgs> mutiDownloadProgressChanged = null,
            Action<object, MutiDownloadCompletedEventArgs> mutiDownloadCompleted = null,
            Action<object, MutiAllDownloadCompletedEventArgs> mutiAllDownloadCompletedAction = null,
            Action<object, MutiDownloadErrorEventArgs> mutiDownloadErrorAction=null,
            Action<object, ExceptionEventArgs> exceptionEventAction = null)
        {
            Url = url ?? throw new ArgumentNullException(nameof(url));
            AppName = appName ?? throw new ArgumentNullException(nameof(appName));
            CurrentVersion = currentVersion ?? throw new ArgumentNullException(nameof(currentVersion));
            VersionFileName = versionFileName ?? "versions.json";
            MutiDownloadStatisticsAction = mutiDownloadStatistics;
            MutiDownloadProgressChangedAction = mutiDownloadProgressChanged;
            MutiDownloadCompletedAction= mutiDownloadCompleted;
            MutiAllDownloadCompletedAction = mutiAllDownloadCompletedAction;
            MutiDownloadErrorAction = mutiDownloadErrorAction;
            ExceptionEventAction = exceptionEventAction;
        }
    }
}