﻿namespace ClientSVH.SendServer
{
    public interface IMessageProducer
    {
        void SendMessage<T>(T message,string CodeCMN);
    }
}
