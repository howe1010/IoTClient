﻿using IoTClient.Core.Models;

namespace IoTClient.Common.Constants
{
    /// <summary>
    /// 
    /// </summary>
    public class SiemensConstant
    {
        /// <summary>
        /// Head头读取长度
        /// </summary>
        public static readonly ushort InitHeadLength = 4;

        /// <summary>
        /// 第一次初始化指令交互报文
        /// </summary>
        public static readonly byte[] Command1 = new byte[22]
        {
            0x03,0x00,0x00,0x16,0x11,0xE0,0x00,0x00,
            0x00,0x01,0x00,0xC0,0x01,0x0A,0xC1,0x02,
            0x01,0x02,0xC2,0x02,0x01,0x00
        };       

        /// <summary>
        /// 第二次初始化指令交互报文
        /// </summary>
        public static readonly byte[] Command2 = new byte[25]
        {
            0x03,0x00,0x00,0x19,0x02,0xF0,0x80,0x32,
            0x01,0x00,0x00,0x04,0x00,0x00,0x08,0x00,
            0x00,0xF0,0x00,0x00,0x01,0x00,0x01,0x01,0xE0
        };

        /// <summary>
        /// 第一次初始化指令交互报文
        /// </summary>
        public static readonly byte[] Command1_200Smart = new byte[22]
        {
            0x03,0x00,0x00,0x16,0x11,0xE0,0x00,0x00,
            0x00,0x01,0x00,0xC1,0x02,0x10,0x00,0xC2,
            0x02,0x03,0x00,0xC0,0x01,0x0A
        };

        /// <summary>
        /// 第二次初始化指令交互报文
        /// </summary>
        public static readonly byte[] Command2_200Smart = new byte[25]
        {
            0x03,0x00,0x00,0x19,0x02,0xF0,0x80,0x32,
            0x01,0x00,0x00,0xCC,0xC1,0x00,0x08,0x00,
            0x00,0xF0,0x00,0x00,0x01,0x00,0x01,0x03,0xC0
        };

        /// <summary>
        /// 第一次初始化指令交互报文
        /// </summary>
        public static readonly byte[] Command1_200 = new byte[]
        {
            0x03,0x00,0x00,0x16,0x11,0xE0,0x00,0x00,
            0x00,0x01,0x00,0xC1,0x02,0x4D,0x57,0xC2,
            0x02,0x4D,0x57,0xC0,0x01,0x09
        };

        /// <summary>
        /// 第二次初始化指令交互报文
        /// </summary>
        public static readonly byte[] Command2_200 = new byte[]
        {
            0x03,0x00,0x00,0x19,0x02,0xF0,0x80,0x32,
            0x01,0x00,0x00,0x00,0x00,0x00,0x08,0x00,
            0x00,0xF0,0x00,0x00,0x01,0x00,0x01,0x03,0xC0
        };
    }
}
