//using UnityEngine;

//public class InputManager : MonoBehaviour
//{
//    public LayerMask plotLayer; // ����, �� ������� ��������� ������
//    public float interactionDistance = 10f; // ������������ ��������� ��� ��������������
//    public GameObject plantWindowUI; // ������ �� UI ��� ������� �����
//    public Plot _currentPlot; // ������ �� ������� ��������� ������

//    public Transform seedSelectionContent;
//    public GameObject seedSelectItemPrefab;

//    private void Update()
//    {
//        if (Input.GetMouseButtonDown(0)) // 0 - ����� ������ ����
//        {
//            CheckPlotClick();
//        }
//    }

//    private void CheckPlotClick()
//    {
//        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
//        RaycastHit hit;

//        if (Physics.Raycast(ray, out hit, interactionDistance, plotLayer))
//        {
//            if (hit.collider.gameObject.TryGetComponent(out Plot clickedPlot))
//            {
//                _currentPlot = clickedPlot;
//                ShowPlantMenu();
//            }
//            else
//            {
//                HidePlantMenu();
//            }
//        }
//        else
//        {
//            HidePlantMenu();
//        }
//    }

//    private void ShowPlantMenu()
//    {
//        if (plantWindowUI == null)
//        {
//            Debug.LogWarning("plantWindowUI is not assigned");
//            return;
//        }

//        ClearSeedList();
//        PopulateSeedList();
//        plantWindowUI.SetActive(true);
//    }

//    private void HidePlantMenu()
//    {
//        if (plantWindowUI == null) return;

//        plantWindowUI.SetActive(false);
//        _currentPlot = null;
//    }

//    public void PlantSelectedSeed(Seed seed)
//    {
//        if (_currentPlot == null) return;
//        _currentPlot.PlantSeed(seed);
//        HidePlantMenu();
//    }


//    //private void PopulateSeedList()
//    //{
//    //    foreach (Seed seed in Shop.Instance.availableSeeds)
//    //    {
//    //        GameObject newSeedObject = Instantiate(seedSelectItemPrefab, seedSelectionContent);
//    //        if (newSeedObject.TryGetComponent<UISeedSelectItem>(out UISeedSelectItem newSeedUI))
//    //        {
//    //            newSeedUI.SetSeed(seed);
//    //        }
//    //    }
//    //}

//    //private void ClearSeedList()
//    //{
//    //    foreach (Transform child in seedSelectionContent)
//    //    {
//    //        Destroy(child.gameObject);
//    //    }
//    //}

//}