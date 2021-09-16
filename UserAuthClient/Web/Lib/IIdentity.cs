using System;

namespace UserAuthClient.Web.Lib
{
    public interface IIdentity
    {
        public string UUID { get; set; }

        public static string CreateUUID => Guid.NewGuid().ToString();

    }
}