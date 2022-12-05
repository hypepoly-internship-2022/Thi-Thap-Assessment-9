using UnityEngine;
using TMPro;

public class Level : MonoBehaviour
{

    [SerializeField] private GameObject btnPrefab;
    [SerializeField] private GameObject inventory;
    [SerializeField] private int levelUWant;

    public string[] textUWant;

    // Start is called before the first frame update
    void Start()
    {   
        SpawnSizeGrid(levelUWant);
        spawnLevelBtn(levelUWant);
    }

    void spawnLevelBtn(int idx){
        for(int i=0; i<idx; i++){
            GameObject btn = Instantiate(btnPrefab, new Vector3(0,0,0), Quaternion.identity);
            btn.transform.SetParent(inventory.transform);
            btn.transform.localScale = new Vector3(1,1,0);
            btn.name = (i+1).ToString();
            for(int j=0; j<btn.transform.childCount; j++){
                Transform curChild = btn.transform.GetChild(j);
                if(curChild.name.Equals("TittleBtnText")){
                    int ran = Random.Range(0,textUWant.Length);
                    curChild.GetComponent<TextMeshProUGUI>().text = textUWant[ran];
                }
            }
        }   

    }

    void SpawnSizeGrid(int idx){
        RectTransform rt = inventory.GetComponent<RectTransform>();
        if(idx > 5){
            rt.sizeDelta = new Vector2(353.13f, 180f * idx);
            rt.localPosition = new Vector3(0, 219f * idx / -2, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

