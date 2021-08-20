using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gecis : MonoBehaviour {
    void sahneGecis(int SahneID)
    {
        SceneManager.LoadScene(SahneID);
    }
	
}
