using UnityEngine;

[CreateAssetMenu]
public class Instancer : ScriptableObject
{
    public void CreateInstance(GameObject obj)
    {
        Instantiate(obj);
    }
}
