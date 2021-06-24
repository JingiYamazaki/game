using UnityEngine;
using System.Collections;
/*
 * Textの文字列やフォントの大きさをスクリプトで変更する際には、
 * using UnityEngine.UI;を記述する必要がある。
 */
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{

	/*
     * Scoreの初期値(最初に持っているコインの枚数)を
     * インスペクタ上から設定できるようにpublic 変数で宣言しておく
     */
	public int initScore;
	int currentScore;
	Text scoreText;

	void Start()
	{
		currentScore = initScore;
		scoreText = this.GetComponent<Text>();
		printScore(initScore);
	}

	// スコアを減点する関数
	public void subScore(int n)
	{
		currentScore -= n;
		printScore(currentScore);
	}

	// スコアを加点する関数
	public void addScore(int n)
	{
		currentScore += n;
		printScore(currentScore);
	}

	void printScore(int n)
	{
		/*
         * ScoreTextのTextに整数を代入する。
         * scoreText.textはstring型(文字列)を受け取るが、nはint型(整数)なので、
         * nをstring型に変換してあげる必要がある。
         */
		scoreText.text = n.ToString();
	}
}
