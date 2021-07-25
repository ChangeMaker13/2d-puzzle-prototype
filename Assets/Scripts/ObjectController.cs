using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    public Transform moving_footrest;
    public Bar[] footrests;
    private SpriteRenderer[] renderers;
    public int selected;

    private int completeOffset = 0;

    public LevelManager levelMgr;

    // Start is called before the first frame update
    void Start()
    {
        int childCnt = moving_footrest.childCount;
        footrests = new Bar[childCnt];
        renderers = new SpriteRenderer[childCnt];

        for(int i = 0; i < childCnt; i++)
        {
            footrests[i] = moving_footrest.GetChild(i).GetComponent<Bar>();
            renderers[i] = moving_footrest.GetChild(i).GetComponent<SpriteRenderer>();
        }
        selected = 1;
        for (int i = -1; i <= 1; i++)
        {
            if (selected + i < 0 || selected + i >= footrests.Length)
                continue;
            renderers[selected + i].color = new Color(0.3915f, 1, 0.9673f);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MoveSelected(int step)
    {
        for (int i = 0; i < footrests.Length; i++)
            renderers[i].color = new Color(1, 1, 1);

        selected = (footrests.Length + selected + step) % footrests.Length;
        for (int i = -1; i <= 1; i++)
        {
            if (selected + i < 0 || selected + i >= footrests.Length)
                continue;

            renderers[selected + i].color = new Color(0.3915f, 1, 0.9673f);
        }
    }

    public void MoveFootRest(int dir)
    {
        for (int i = -1; i <= 1; i++)
        {
            if (selected + i < 0 || selected + i >= footrests.Length)
                continue;

            footrests[selected + i].Move(dir);
        }
        CheckComplete();
    }

    public void CheckComplete()
    {
        for(int i = 0; i < footrests.Length; i++)
        {
            if (footrests[i].CheckAligned())
                continue;
            else
                return;
        }

        for (int i = 0; i < footrests.Length; i++)
            renderers[i].color = new Color(1, 1, 1);

        levelMgr.MoveBike();
    }
}
