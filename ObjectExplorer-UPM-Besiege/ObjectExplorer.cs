using ObjectExplorerMod.UI;
using UnityEngine;
using Modding;

namespace ObjectExplorerMod
{
    public class ObjectExplorer : SingleInstance<ObjectExplorer>
    {
        public override string Name
        {
            get { return "Object Explorer - UPM Edition"; }
        }

        public string WindowTitle = "Object Explorer - UPM Edition";

        public HierarchyPanel HierarchyPanel { get; private set; }
        public InspectorPanel InspectorPanel { get; private set; }

        private readonly int windowID = ModUtility.GetWindowId();
        private Rect windowRect = new Rect(20, 20, 800, 600);
       
        public bool IsVisible = false;

        private void Start()
        {
            //DontDestroyOnLoad(Instance);
            HierarchyPanel = gameObject.AddComponent<HierarchyPanel>();
            InspectorPanel = gameObject.AddComponent<InspectorPanel>();
        }

        private void Update()
        {
            if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.O))
            {
                ObjectExplorer.Instance.IsVisible = !ObjectExplorer.Instance.IsVisible;
            }
        }

        private void OnGUI()
        {
            GUI.skin = ModGUI.Skin;

            if (IsVisible) { windowRect = GUILayout.Window(windowID, windowRect, DoWindow, WindowTitle); }
        }

        private void DoWindow(int id)
        {
            GUILayout.BeginHorizontal();

            HierarchyPanel.Display();
            InspectorPanel.Display();

            GUILayout.EndHorizontal();

            GUI.DragWindow(new Rect(0, 0, windowRect.width, GUI.skin.window.padding.top));
        }
    }
}

