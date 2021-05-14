using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class InfoGame 
{
    public static bool isSavedGame = false;
    public static bool isNotSavedGame = true;

    public static class InfoPlayer
    {
        public static Vector2 checkpointPosition;
        public static int verticesRecogidos;
    }

    public class InfoVertice
    {
        public bool active;
    }

    public static List<InfoVertice> infoVertice = new List<InfoVertice>();

}
