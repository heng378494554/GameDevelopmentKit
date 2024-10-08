﻿using Cysharp.Threading.Tasks;

namespace ET.Client
{
    [MessageHandler(SceneType.NetClient)]
    public class A2NetClient_MessageHandler: MessageHandler<Scene, A2NetClient_Message>
    {
        protected override async UniTask Run(Scene root, A2NetClient_Message message)
        {
            root.GetComponent<SessionComponent>().Session.Send(message.MessageObject);
            await UniTask.CompletedTask;
        }
    }
}