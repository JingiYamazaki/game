using UnityEngine;
using System.Collections;

public class SaucerScript : MonoBehaviour
{

    // 追加 ：scoreTextをインスペクタ上に表示させる
    public GameObject scoreText;
    ScoreScript scoreS;

    AudioSource getSE;

    void Start()
    {
        scoreS = scoreText.GetComponent<ScoreScript>();
        // 追加 : Saucerに付けたAudioSourceコンポーネントをとってくる
        getSE = this.GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision colObject)
    {
        if (colObject.gameObject.tag == "Coin")
        {
            Destroy(colObject.gameObject);
            scoreS.addScore(2);
            // 追加 : PlayOneShotでAudioClipに入れた音を一度だけ鳴らす
            getSE.PlayOneShot(getSE.clip);
        }
    }
}