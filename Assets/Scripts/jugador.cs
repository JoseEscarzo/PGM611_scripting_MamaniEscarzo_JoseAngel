using UnityEngine;

public class jugador : MonoBehaviour
{
    public float velocidad = 5f;
    private Rigidbody2D rb;
    private float movimiento;
    public float alturaSalto = 4f;
    private bool esPiso; // el true quiere decir estamos en el piso y false que estamos en el aire
    public Transform comprobadorPiso;
    public float radioComprobadorPiso = 0.1f;
    public LayerMask layerPiso;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movimiento = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(movimiento * velocidad, rb.linearVelocity.y);
        if (movimiento != 0) transform.localScale = new Vector3(Mathf.Sign(movimiento), 1, 1);
        if (Input.GetButtonDown("Jump") && esPiso)
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, alturaSalto);
    }
    public void FixedUpdate()
    {
        esPiso = Physics2D.OverlapCircle(comprobadorPiso.position, radioComprobadorPiso, layerPiso);
    }
}

