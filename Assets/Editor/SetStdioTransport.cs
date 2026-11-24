using UnityEditor;
using UnityEngine;

public class SetStdioTransport
{
    [MenuItem("Tools/MCP/Enable Stdio Transport")]
    public static void EnableStdioTransport()
    {
        EditorPrefs.SetBool("MCPForUnity.UseHttpTransport", false);
        Debug.Log("Set MCPForUnity.UseHttpTransport to false");
        MCPForUnity.Editor.Services.Transport.Transports.StdioBridgeHost.StartAutoConnect();
    }
}
