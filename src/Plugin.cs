using BepInEx;
using System;
using System.Reflection;
using System.Collections;
using UnityEngine;

[BepInPlugin("com.yourname.lodmod", "LOD Mod", "1.0.0")]
public class LODMod : BaseUnityPlugin
{
    private void Awake()
    {
        StartCoroutine(SetLODWithDelay());
    }

    private IEnumerator SetLODWithDelay()
    {
        // Wait for 18 seconds to ensure Unity is fully initialized
        yield return new WaitForSeconds(18f);

        try
        {
            Type qualitySettingsType = Type.GetType("UnityEngine.QualitySettings, UnityEngine.CoreModule");

            var lodBiasProperty = qualitySettingsType?.GetProperty("lodBias");
            lodBiasProperty?.SetValue(null, 15000f, null);
            Logger.LogInfo("\u001b[31mLOD set to 15000!\u001b[0m");

        }
        catch (Exception e)
        {
            Logger.LogError($"Error: {e}");
        }
    }
}