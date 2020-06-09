﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map
{
    public int[,] mapData { get; private set; }

    public Vector2 size { get; private set; }

    public float length { get; private set; }


    public void Init()
    {
        mapData = initDefaultData();
    }

    public void Release()
    {
        mapData = null;
    }

    /// <summary>
    /// 获取地图数据
    /// </summary>
    /// <returns></returns>
    private int[,] initDefaultData()
    {
        int[,] map_data = new int[,]{
                           { 1, 1, 1, 1},                
                           { 1, 0, 0, 1},                
                           { 1, 0, 0, 1},                
                           { 1, 0, 0, 1},                
                           { 1, 0, 0, 1},                
                           { 1, 0, 0, 1},                
                           { 1, 0, 0, 1},                
                           { 1, 0, 0, 1},                
                           { 1, 0, 0, 1},                
                           { 1, 0, 0, 1},                
                           { 1, 0, 0, 1},                
        };
        return map_data;
    }

    public int GetValue(int x,int y)
    {
        return mapData[y,x];
    }   

    public void SetValue(int x, int y,int value)
    {
        mapData.SetValue(value, y, x);
    }
}
