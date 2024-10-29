using UnityEngine;
public class ExampleControl : MonoBehaviour
{
    public float xSpeed;
    public int xDirection;
    private Transform _componentTransform;
    private SpriteRenderer _componentSpriteRenderer;
    void Start()
    {

    }
    // Start is called before the first frame update
    void Awake()
    {
        _componentTransform = GetComponent<Transform>();
        _componentSpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        Movement();
    }
    void Movement()
    {
        _componentTransform.position = new Vector2(_componentTransform.position.x + xSpeed * 2 * xDirection * Time.deltaTime,
          _componentTransform.position.y);
        if (_componentTransform.position.x >= 7.36f)
        {
            xDirection = -1;
            _componentSpriteRenderer.flipX = true;
        }
        else if (_componentTransform.position.x <= -7.36f)
        {
            xDirection = 1;
            _componentSpriteRenderer.flipX = false;
        }
    }
}
