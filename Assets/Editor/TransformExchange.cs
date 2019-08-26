using UnityEditor;
using UnityEngine;

public class TransformExchange : ScriptableWizard
{
    // две публичные переменные, которые будут параметрами визарда
    public Transform source1; // объект для поворота
    public Transform source2; // объект для поворота
    public Transform source3; // объект для поворота
    public Transform source4; // объект для поворота
    public Transform source5; // объект для поворота
    public Transform source6; // объект для поворота
    public Transform source7; // объект для поворота
    public Transform target1; // цель
    public Transform target2; // цель
    public Transform target3; // цель
    public Transform target4; // цель
    public Transform target5; // цель
    public Transform target6; // цель
    public Transform target7; // цель






    private Vector3 vector;
    // регистрация функции создания визарда в меню Unity
    [MenuItem("Window/Look At Wizard")]
    static void CreateWizard()
    {
        // создаем визард с одной кнопкой "Look At!"
        ScriptableWizard.DisplayWizard<TransformExchange>("Look At", "Look At!");

        // если необходимо реализовать вторую 
        // кнопку, то можно воспользоваться
        // другой перегрузкой метода 
        // ScriptableWizard.DisplayWizard<> 
        // и реализовать функцию 
        // void OnWizardOtherButton ()
    }

    // флаг успешной настройки визарда
    private bool _wizardOk = false;

    // выполнение функции визарда - OnWizardCreate()
    void OnWizardCreate()
    {
        // выполняем только когда исходные данные верны
        if (_wizardOk)
        {
            vector=source1.position;
            source1.position = target1.position;
            target1.position = vector;
            vector = source2.position;
            source2.position = target2.position;
            target2.position = vector;
            vector = source3.position;
            source3.position = target3.position;
            target3.position = vector;
            vector = source4.position;
            source4.position = target4.position;
            target4.position = vector;
            vector = source5.position;
            source5.position = target5.position;
            target5.position = vector;
            vector = source6.position;
            source6.position = target6.position;
            target6.position = vector;
            vector = source7.position;
            source7.position = target7.position;
            target7.position = vector;
        }
    }

    // функция выполняется при создании визарда 
    // и при изменении исходных данных пользователем
    void OnWizardUpdate()
    {
        _wizardOk = false;
        // один из параметров не указан
        if (source1 == null || target1 == null)
        {
            // helpString выдает подсказки пользователю
            helpString = "Selcect Source and Target!";
        }
        // если цель и объект совпадают
        else if ((source1 == target1) && (source1 != null))
        {
            helpString = "Source equals Target!";
        }
        else
        {
            // все проверки пройдены
            helpString = "Press \"Look At!\"!";
            _wizardOk = true;
        }
    }
}
