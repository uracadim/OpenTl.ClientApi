﻿namespace OpenTl.ClientApi.MtProto
{
    using OpenTl.Schema;

    public interface IClientSettings
    {
        int AppId { get; set; }

        string AppHash { get; set; }

        string PublicKey { get; set; }

        IClientSession ClientSession { get; set; }
        
        IConfig Config { get; set; }
        
        TUser User { get; set; }
    }
}