using UnityEngine;

[CreateAssetMenu]
public class Instancer : ScriptableObject
{
    public GameObject prefab;
    
    public void CreateInstance()
    {
        Instantiate(prefab);
    }

    public void CreateInstance(Vector3Data obj)
    {
        //Quaternion.Identity means that we are not going to rotate the object at all. Rotate values at 0.
        Instantiate(prefab, obj.value, Quaternion.identity);
    }
}
