using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public abstract class BaseModule : BaseObject, IEndDragHandler, IDragHandler, IDropHandler
{
    public string moduleID;

    private RectTransform rectTransform;

    [SerializeField] private float _executionTime;
    [SerializeField] private ModuleAdapter _head = null;
    [SerializeField] private ModuleAdapter _tail = null;

    private ModuleController m_moduleController;

    public float ExecutionTime
    {
        get => _executionTime;
        set 
        {
            if (value > 0f)
            {
                _executionTime = value;                
            }

            else
            {
                print("Error : Time has to be over than 0!");                
            }
        }        
    }

    public ModuleAdapter Head
    {
        get => _head;
        set => _head = value;
    }

    public ModuleAdapter Tail
    {
        get => _tail;
        set => _tail = value;
    }

    public BaseModule Parent
    {
        get 
        {
            if (Head != null)
            {
                return Head.AttachedAdapter.Module;
            }

            return null;
        }
    }

    public BaseModule Next
    {
        get
        {
            if (Tail != null)
            {
                return Tail.AttachedAdapter.Module;
            }

            return null;
        }
    }

    protected override void Awake()
    {
        base.Awake();
        
        if(!TryInitialize())
        {
            print(string.Format("{0} has a error!", this.name));
        }
    }

    protected override bool TryInitialize()
    {
        base.TryInitialize();
        m_moduleController = ModuleController.Instance;
        rectTransform = GetComponent<RectTransform>();
        return true;
    }

    public abstract void ModuleAction();

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        print(this.name);
    }


    private RaycastHit[] hit2Ds;

    public void OnDrop(PointerEventData eventData)
    {
        var pos = eventData.position;

        Ray ray = Camera.main.ScreenPointToRay(pos);
        hit2Ds = Physics.RaycastAll(ray, Mathf.Infinity);

        foreach(var hit in hit2Ds)
        {
            print(hit.collider.gameObject.name);
        }
    }
}