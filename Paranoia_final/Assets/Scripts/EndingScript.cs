using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndingScript : MonoBehaviour
{
    public static EndingScript instance;

    public GameObject back1;
    public GameObject btntoMenu;
    public GameObject gametext1;

    public GameObject x;

    #region Singleton
    private void Awake()
    {
        if (instance == null)
        {
            //DontDestroyOnLoad(this.gameObject);
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    #endregion Singleton

    public Text text;
    //public SpriteRenderer renderSprite;
    //public SpriteRenderer rendererDialogueWindow;

    public List<string> listSentences;
    //public List<Sprite> listSprites;
    //public List<Sprite> listDialogueWindows;

    private int count; // 대화 진행 상황 카운트
    private bool talking;

    private void Start()
    {
        count = -1;
        text.text = "";
        listSentences = new List<string>();

        back1.SetActive(false);
        gametext1.SetActive(false);
        
        //listSprites = new List<Sprite>();
        //listDialogueWindows = new List<Sprite>();
    }

    public void ShowDialogue(Dialogue dialogue)
    {
        for (int i = 0; i < dialogue.sentences.Length; i++)
        {
            listSentences.Add(dialogue.sentences[i]);
            //listSprites.Add(dialogue.sprites[i]);
            //listDialogueWindows.Add(dialogue.dialogueWindows[i]);
        }

        StartCoroutine(StartDialogueCoroutine());
    }

    public void ExitDialogue()
    {
        //talking = false;

        text.text = "";
        count = 0;
        listSentences.Clear();
        //listSprites.Clear();
        //listDialogueWindows.Clear();
    }

    IEnumerator StartDialogueCoroutine()
    {
        /*
        if (count > 0)
        {
            if (listDialogueWindows[count] != listDialogueWindows[count - 1])
            {
                yield return new WaitForSeconds(0.1f);
            }
            else
            {
                if (listSprites[count] != listSprites[count - 1])
                {
                    yield return new WaitForSeconds(0.1f);
                }
                else
                {
                    yield return new WaitForSeconds(0.1f);
                }
            }
           
        }
        */
        //talking = true;

        for (int i = 0; i < listSentences[count].Length; i++)
        {
            text.text += listSentences[count][i]; // 1글자씩 출력
            yield return new WaitForSeconds(0.01f);
            
        }


    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            count++;
            text.text = "";

            if (count == listSentences.Count)
            {
                StopAllCoroutines();
                ExitDialogue();
            }
            else
            {
                StopAllCoroutines();
                StartCoroutine(StartDialogueCoroutine());
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            
            count++;
            text.text = "";
            if(count == 4)
            {
                x.SetActive(true);
            }
            if (count == 5)
            {
                x.SetActive(false);
                back1.SetActive(true);
                gametext1.SetActive(true);
                btntoMenu.SetActive(true);
            }
        }
    }

    /*
    [SerializeField]
    public static EndingScript instance = null;
    public List<Dialog_cycle> dialog_cycles = new List<Dialog_cycle>();
    public Queue<string> text_seq = new Queue<string>();
    public string _name;
    public string _text;

    public Text nameing;
    public Text DialogT;
    public Button Next_b;
    public GameObject dialog_obj;

    IEnumerator _seq;
    IEnumerator skip_seq;

    public float delay;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if(instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);

    }

    public IEnumerator dialog_system_start(int index)
    {
        nameing = dialog_obj.GetComponent<parameter>().name_text;
        DialogT = dialog_obj.GetComponent<parameter>().content;
        Next_b = dialog_obj.GetComponent<parameter>().next_btn;

        foreach (dialog_info dialog_temp in dialog_cycles[index].info)
        {
            text_seq.Enqueue(dialog_temp.info);
        }

        dialog_obj.gameObject.SetActive(true);
        for(int i= 0; i < dialog_cycles[index].infos.Count; i++)
        {
            nameing.text = dialog_cycles[index].info[i].name;
            _text = text_seq.Dequeue();
            Next_b.onClick.AddListener(() => { DisplayNext(index, i); });
            _seq = seq_sentence(index, i);
            StartCoroutine(_seq);

            yield return new WaitUntil(() =>
            {
                if (dialog_cycles[index].info[i].check_read)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            });
        }
        Next_b.onClick.RemoveAllListeners();
        dialog_cycles[index].check_cycle_read = true;
    }

    public void DisplayNext(int index, int number)
    {
        if (text_seq.Count == 0)
        {
            dialog_obj.gameObject.SetActive(false);
        }
        StopCoroutine(_seq);

        dialog_cycles[index].info[number].check_read = true;
    }

    public IEnumerator seq_sentence(int index, int number)
    {
        skip_seq = touch_wait(_seq, index, number);
        StartCoroutine(skip_seq);
        DialogT.text = "";
        foreach(char letter in _text.ToCharArray())
        {
            DialogT.text += letter;
            yield return new WaitForSeconds(delay);
        }

        StopCoroutine(skip_seq);
        IEnumerator next = next_touch(index, number);
        StartCoroutine(next);
    }

    public IEnumerator touch_wait(IEnumerator seq, int index, int number)
    {
        yield return new WaitForSeconds(0.3f);
        yield return new WaitUntil(() => Input.GetMouseButton(0));
        StopCoroutine(seq);
        DialogT.text = _text;
        IEnumerator next = next_touch(index, number);
        StartCoroutine(next);
    }

    public IEnumerator next_touch(int index, int number)
    {
        StopCoroutine(_seq);
        StopCoroutine(skip_seq);
        yield return new WaitForSeconds(0.3f);
        yield return new WaitUntil(() => Input.GetMouseButton(0));
        DisplayNext(index, number);
    }

    public bool dialog_Read(int check_index)
    {
        if(!dialog_cycles[check_index].check_cycle_read)
        {
            return true;
        }
        return false;
    }
    */
}
