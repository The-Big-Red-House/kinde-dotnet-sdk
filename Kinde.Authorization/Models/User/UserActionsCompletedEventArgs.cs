﻿namespace Kinde.Authorization.Models.User
{
    public class UserActionsCompletedEventArgs : EventArgs
    {
        public string Code { get; set; }
        public string State { get; set; }
    }
}
