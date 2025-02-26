﻿#region 模块信息
// **********************************************************************
// Copyright (C) 2019 QIANFENG EDUCATION
//
// 文件名(File Name):ConnectPhoton.cs
// 公司(Company):#COMPANY#
// 作者(Author):#AUTHOR#
// 版本号(Version):#VERSION#
// Unity版本	(Unity Version):#UNITYVERSION#
// 创建时间(CreateTime):#DATE#
// 修改者列表(modifier):无
// 模块描述(Module description):ConnectPhoton
// **********************************************************************
#endregion
using UnityEngine;
using System.Collections;
using Photon.Pun;

public class ConnectPhoton : MonoBehaviour {
    private void Start() {
        PhotonNetwork.AutomaticallySyncScene = true;
        PhotonNetwork.ConnectUsingSettings();
        PhotonNetwork.SendRate = 60;
    }
}