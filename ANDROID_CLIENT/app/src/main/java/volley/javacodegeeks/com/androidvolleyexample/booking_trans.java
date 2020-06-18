package volley.javacodegeeks.com.androidvolleyexample;

import android.app.Activity;
import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
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
import org.json.JSONException;
import org.json.JSONObject;

import java.util.ArrayList;
import java.util.List;

import volley.javacodegeeks.com.androidvolleyexample.R;

public class booking_trans extends Activity {
    Button btnbook;
    LinearLayout ly;
    Spinner tujuan;
    List<String> index=new ArrayList<>();
    List<String> indexharga=new ArrayList<>();
    EditText id,hargatiket;
    String idTiket,harga;
    private String IDCus;
    public String kunci="kunci";
    @Override
    public void onCreate(Bundle transaksi) {
        super.onCreate(transaksi);
        setContentView(R.layout.book_transaksi);
        btnbook=findViewById(R.id.btnbook);
        ly=findViewById(R.id.lay2);
        id=findViewById(R.id.idcustnya);
        hargatiket=findViewById(R.id.harga);
        tujuan=findViewById(R.id.spinnertujuan);
        Bundle extras=getIntent().getExtras();
        IDCus=extras.getString(kunci);
        id.setText(IDCus);
        loadSpinner();

    }
    public void loadSpinner(){

        final ArrayAdapter dataadapter=new ArrayAdapter<>(this,android.R.layout.simple_spinner_item);
        final RequestQueue requestQueue= Volley.newRequestQueue(this);
        final String url="http://192.168.43.136/web_sister/REST_API/api/tiket";
        JsonObjectRequest jsonObjectRequest = new JsonObjectRequest(Request.Method.GET, url, null, new Response.Listener<JSONObject>() {
            @Override
            public void onResponse(JSONObject response) {
                try {
                    JSONArray responseJSONArray = response.getJSONArray("data");//nama Array
                    for (int i = 0; i < responseJSONArray.length(); i++) {
                        index.add(responseJSONArray.getJSONObject(i).get("idTiket").toString());
                        indexharga.add(responseJSONArray.getJSONObject(i).get("harga").toString());
                        dataadapter.add(responseJSONArray.getJSONObject(i).get("tujuan").toString());
                        tujuan.setAdapter(dataadapter);
                    }
                } catch (JSONException e) {
                    e.printStackTrace();
                }
            }
        }, new Response.ErrorListener() {
            @Override
            public void onErrorResponse(VolleyError error) {
                Toast.makeText(getBaseContext(),"An Error occured while making the request",Toast.LENGTH_LONG);
            }
        });
        requestQueue.add(jsonObjectRequest);
    }
    public void insertTR(){
        int i=tujuan.getSelectedItemPosition();
        idTiket=index.get(i);
        harga=indexharga.get(i);
        hargatiket.setText(harga);
        JSONObject postparam = null;
        try {
            postparam = new JSONObject();
            postparam.put("idCustomer", id.getText().toString());
            postparam.put("idTiket", idTiket);
            postparam.put("status","0");
        } catch (Exception e) {
            Toast.makeText(this, e.toString(), Toast.LENGTH_LONG).show();
        }
        String url1 = "http://192.168.43.136/web_sister/REST_API/api/transaksi";
        RequestQueue requestQueue1 = Volley.newRequestQueue(this);
        JsonObjectRequest jsonObjectRequest1 = new JsonObjectRequest(Request.Method.POST, url1, postparam, new Response.Listener<JSONObject>() {
            @Override
            public void onResponse(JSONObject response) {

            }

        }, new Response.ErrorListener() {
            @Override
            public void onErrorResponse(VolleyError error) {
                Toast a=Toast.makeText(getBaseContext(),"BERHASIL",Toast.LENGTH_LONG);
                a.show();
            }
        });
        requestQueue1.add(jsonObjectRequest1);
    }

    public void insertTrans(View view) {
        insertTR();
    }
}
