using System.Collections.Generic;
using UnityEngine;

public static class YieldRegistry
{
    public static WaitForEndOfFrame WaitForEndOfFrame => endOfFrame ??= new WaitForEndOfFrame();

    private static WaitForEndOfFrame endOfFrame;

    private static readonly Dictionary<float, WaitForSeconds> yieldRegistry = new Dictionary<float, WaitForSeconds>();

    public static WaitForSeconds WaitForSeconds(float seconds)
    {
        yieldRegistry.TryGetValue(seconds, out WaitForSeconds yield); 
        return yield ?? RegisterNewYield(seconds);
    }

    private static WaitForSeconds RegisterNewYield(float seconds)
    {
        WaitForSeconds yield = new WaitForSeconds(seconds);
        yieldRegistry.Add(seconds, yield);
        return yield;
    }
}
