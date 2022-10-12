using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeSpawnerScript : MonoBehaviour
{
    [SerializeField] CubeScript cube;
    [SerializeField] float speed = 1;
    [SerializeField] float distance = 1;
    [SerializeField] float delay = 1;

    [SerializeField] InputField speedField;
    [SerializeField] InputField distanceField;
    [SerializeField] InputField delayField;

    private float time = 0;

    public void UpdateValues() //обновление значений, вызываетс€ из интерфейса при изменении значений InputField
    {
        try { speed = float.Parse(speedField.text); }
        catch { speedField.text = "Error! Incorrect Values!"; }
        try { distance = float.Parse(distanceField.text); }
        catch { distanceField.text = "Error! Incorrect Values!"; }
        try { delay = float.Parse(delayField.text); }
        catch { delayField.text = "Error! Incorrect Values!"; }
    }

    void SpawnCube() //—павн куба, дальнейшие манипул€ции производ€тс€ в скрипте CubeScript
    {
        CubeScript cubeObj = Instantiate(cube);

        cubeObj.transform.position = transform.position;

        cubeObj.SetParams(speed, distance);
    }


    private void Update()
    {
        time -= Time.deltaTime;

        if (time < 0)
        {
            SpawnCube();
            time = delay;
        }
    }
}
