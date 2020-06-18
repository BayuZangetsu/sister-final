package volley.javacodegeeks.com.androidvolleyexample;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.LinearLayout;
import android.widget.Spinner;
import android.widget.Toast;

import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.JsonObjectRequest;
import com.android.volley.toolbox.Volley;

import org.json.JSONArray;
import org.json.JSONObject;


public class activity_booking extends Activity {
    Spinner kelamin;
    EditText nama,nik,alamat;
    Button btndaftar,btnbook;
    LinearLayout ly;
    String idcust;
    public String kunci="kunci";
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.daftar_tiket);
        nama=findViewById(R.id.namalengkap);
        nik=findViewById(R.id.nonik);
        kelamin=findViewById(R.id.spinnersex);
        alamat=findViewById(R.id.alamatlengkap);
        btndaftar=findViewById(R.id.btnNext);

    }
    public void daftarbio(View view) {
        postBio();
        pindah();
    }
    public void postBio() {
        JSONObject postparam = null;
        try {
            postparam = new JSONObject();
            postparam.put("nik", nik.getText().toString());
            postparam.put("namaCustomer", nama.getText().toString());
            postparam.put("sex", kelamin.getSelectedItem().toString());
            postparam.put("alamatCustomer", alamat.getText().toString());
        } catch (Exception e) {
            Toast.makeText(this, e.toString(), Toast.LENGTH_LONG).show();
        }
        String url = "http://192.168.43.136/web_sister/REST_API/api/pelanggan";
        RequestQueue requestQueue = Volley.newRequestQueue(this);
        JsonObjectRequest jsonObjectRequest = new JsonObjectRequest(Request.Method.POST, url, postparam, new Response.Listener<JSONObject>() {
            @Override
            public void onResponse(JSONObject response) {
                getData();
            }

        }, new Response.ErrorListener() {
            @Override
            public void onErrorResponse(VolleyError error) {
                Toast a=Toast.makeText(getBaseContext(),"BERHASIL",Toast.LENGTH_LONG);
                a.show();
            }
        });
//        {
//            @Override
//            public Map<String, String> getHeaders() throws AuthFailureError {
//                HashMap headers = new HashMap();
//                headers.put("Content-Type", "application/json");
//                headers.put("nik", nik.getText().toString());
//                headers.put("namaCustomer", nama.getText().toString());
//                headers.put("sex", kelamin.getSelectedItem().toString());
//                headers.put("alamatCustomer", alamat.getText().toString());
//                return super.getHeaders();
//            }
        requestQueue.add(jsonObjectRequest);
    }
    public void getData(){
        String id=nik.getText().toString();
        final RequestQueue requestQueue = Volley.newRequestQueue(this);
        final String url="http://192.168.43.136/web_sister/REST_API/api/pelanggan?nik="+id;
        JsonObjectRequest jsonObjectRequest=new JsonObjectRequest(Request.Method.GET, url, null, new Response.Listener<JSONObject>() {
            @Override
            public void onResponse(JSONObject response) {
                try{
                    JSONArray responseJSONArray = response.getJSONArray("data");
                    for(int i=0;i<responseJSONArray.length();i++){
                        idcust=responseJSONArray.getJSONObject(i).get("idCustomer").toString();
                    }
                }
                catch (Exception e){
                    Toast a=Toast.makeText(getBaseContext(),e.toString(),Toast.LENGTH_LONG);
                    a.show();
                }
            }
        }, new Response.ErrorListener() {
            @Override
            public void onErrorResponse(VolleyError error) {

            }
        });
        requestQueue.add(jsonObjectRequest);
    }
    public void pindah(){
        Intent i=new Intent(this,booking_trans.class);
        i.putExtra(kunci,idcust);
        startActivity(i);
    }
    }
