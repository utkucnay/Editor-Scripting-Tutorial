using UnityEngine;
using UnityEditor;

public class MenuItemsExample {
    
    // Add a new menu item under an existing menu

    [MenuItem("Window/New Option")]
    private static void NewMenuOption()
    {
    }

    // Add a menu item with multiple levels of nesting

    [MenuItem("Tools/SubMenu/Option")]
    private static void NewNestedOption()
    {
    }
}

public class HotkeysExample {

    // Add a new menu item with hotkey CTRL-SHIFT-A

    [MenuItem("Tools/New Option %#a")]
    private static void NewMenuOption()
    {
    }

    // Add a new menu item with hotkey CTRL-G

    [MenuItem("Tools/Item %g")]
    private static void NewNestedOption()
    {
    }

    // Add a new menu item with hotkey G
    [MenuItem("Tools/Item2 _g")]
    private static void NewOptionWithHotkey()
    {
    }
}

public class SpecialPathExample {

    // Add a new menu item that is accessed by right-clicking on an asset in the project view

    [MenuItem("Assets/Load Additive Scene")]
    private static void LoadAdditiveScene()
    {
        var selected = Selection.activeObject;
        EditorApplication.OpenSceneAdditive(AssetDatabase.GetAssetPath(selected));
    }

    // Adding a new menu item under Assets/Create

    [MenuItem("Assets/Create/Add Configuration")]
    private static void AddConfig()
    {
        // Create and add a new ScriptableObject for storing configuration
    }

    // Add a new menu item that is accessed by right-clicking inside the RigidBody component

    [MenuItem("CONTEXT/Rigidbody/New Option")]
    private static void NewOpenForRigidBody()
    {
    }
}

public class ControllingOrderWithPriority {

    [MenuItem("NewMenu/Option1", false, 1)]
    private static void NewMenuOption()
    {
    }

    [MenuItem("NewMenu/Option2", false, 2)]
    private static void NewMenuOption2()
    {
    }

    [MenuItem("NewMenu/Option3", false, 3)]
    private static void NewMenuOption3()
    {
    }

    [MenuItem("NewMenu/Option4", false, 51)]
    private static void NewMenuOption4()
    {
    }

    [MenuItem("NewMenu/Option5", false, 52)]
    private static void NewMenuOption5()
    {
    }
}

public class RelatedClasses {
    
    [MenuItem("CONTEXT/Rigidbody/New Option")]
    private static void NewMenuOption(MenuCommand menuCommand)
    {
        // The RigidBody component can be extracted from the menu command using the context field.
        var rigid = menuCommand.context as Rigidbody;
    }
}
