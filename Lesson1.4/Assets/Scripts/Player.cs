
using TMPro;

using UnityEngine;


public class Player : MonoBehaviour
{
    private int _myCondition = 0;  // Тип игры - 0 это цветные шары, 1 это все шары
    private int _startColor = -1;  // Цвет который собираем. Для типа игры 0
    [SerializeField] private GameObject _startCanvas;   // Канвас старта - две кнопки и мини-инструкция
    [SerializeField] private GameObject _badCanvas;     // Канвас проигрыша
    [SerializeField] private GameObject _goodCanvas;    // Канвас выигрыша - не стал заморачиваться - сделал два...
    [SerializeField] TextMeshProUGUI _res;              // Счетчик нажатых шаров на канвасе

    [SerializeField] private int _countOfColors = 5;    // Количество цветов шаров
    [SerializeField] private int _countOfSpheres=5;     // Количество шариков на площадке
    private int _count = 0;                             // Количество шариков, на которые уже нажали и сняли с площадки

    [SerializeField] private GameObject _spherePrefab;  // Префаб шарика
    private GameObject newSphere;                       // Шарик
    private MyColors clr;                               // Экземпляр класса цветов
    private int[] colorGoals;                           // Массив количества шаров по разным цветам


    public void StartGame(int cnd)
    {
        _myCondition = cnd;                                     // Сюда попадаем после нажатия кнопки на стартовм канвасе сразу с типом игры
        _startColor = -1;                                       // Стартовый цвет пока неизвестен
        _count = 0;                                             // Шарики пока не нажимались
        _startCanvas.SetActive(false);                          // Уберем канвас старта
        colorGoals=new int[_countOfColors];                     // Соберем массив целевого количества по цветам
        for (int i = 0;i<_countOfColors;i++) colorGoals[i]=0;   // Он пока пустой

        clr = new MyColors();
        clr.LoadMyColors(_countOfColors);

        for (int i = 0; i < _countOfSpheres; i++)
        {
            Vector3 newPosition = new Vector3(UnityEngine.Random.Range(-8f, 8f), 0, UnityEngine.Random.Range(-4f, 4f));
            newSphere = GameObject.Instantiate(_spherePrefab, newPosition, Quaternion.Euler(0, 0, 0));

            int tp = UnityEngine.Random.Range(0, _countOfColors);               // Какой же будет тип шара?
            newSphere.GetComponent<SphereClass>().SetType(tp,clr.GetColor(tp)); // Запишем тип шара и цвет, ему соответствующий
            colorGoals[tp]++;   // Добавим количество шаров по данному типу


         }
        SphereClass.chpokEvent += SetChpok;     // Подписываемся на шарики
    }

    private void SetChpok(int tp)               // Подписка сработала - решаем что делать с мертвым шариком
    {
        if (_startColor == -1) _startColor = tp;// О - это первый нажатый!
        _count++;                               // В любом случае количество увеличиваем

        if (_myCondition == 0)                  // Если 0 - то чпокаем цветные шарики
        {
            if (_startColor != tp)              // Если ошиблись цветом, то выход на проигрыш
            {
                BadFinal();
                return;
            }
            if (colorGoals[_startColor] == _count) GoodFinal();     // Если достигли цели, то к канвасу победы
              else _res.text = _count.ToString() + " / " + colorGoals[_startColor].ToString(); // Или обновляем счетчик
        }
        else                    // Собираем все шары - тут все просто
        {
            if (_countOfSpheres == _count) GoodFinal();
            else  _res.text = _count.ToString() + " / " + _countOfSpheres.ToString();

        }
    }

    private void GoodFinal()
    {
        _goodCanvas.SetActive(true);
    }
    private void BadFinal()
    {
        _badCanvas.SetActive(true);

    }


}
