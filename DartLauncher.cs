using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DartLauncher : MonoBehaviour
{
    [SerializeField] Dart _dartPrefab;
    Dart _currentlyLoadedDart;

    // Start is called before the first frame update
    void Start()
    {
        SpawnDart();
    }

    
    
    
    
    
    
    
    
    
    
    private void SpawnDart()
    {
       _currentlyLoadedDart = Instantiate(_dartPrefab, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (_currentlyLoadedDart != null && Input.GetButtonDown("Fire1"))
        {
            _currentlyLoadedDart.Fire();
            _currentlyLoadedDart = null;
            Invoke(nameof(SpawnDart), 1);
        }
    }
}
