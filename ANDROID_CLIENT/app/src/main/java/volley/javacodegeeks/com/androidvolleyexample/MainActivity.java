package volley.javacodegeeks.com.androidvolleyexample;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import android.content.Context;
import android.content.DialogInterface;
import android.graphics.drawable.Icon;
import android.os.Bundle;
import android.support.v7.app.AlertDialog;
import android.support.v7.app.AppCompatActivity;
import android.text.TextUtils;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.LinearLayout;
import android.widget.ListAdapter;
import android.widget.ListView;
import android.widget.TableRow;
import android.widget.TextView;
import android.widget.Toast;

import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.JsonObjectRequest;
import com.android.volley.toolbox.Volley;

import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {
    TextView hasilid,hasilcus,hasiltgl,hasiltiket,hasilstatus,alamat,kelamin,nik,nama,tujuan,harga;
    private EditText txtId;
    private Button cari;
    ListView list;
    LinearLayout linearLayoutlist;
    String idtransaksi,idCus,idTiket,Status;
    Context context;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.cek_tiket);
        txtId=findViewById(R.id.editText);
        cari=findViewById(R.id.btnCari);
        hasilid=findViewById(R.id.idtrans);
        hasilcus=findViewById(R.id.idcust);
        hasiltiket=findViewById(R.id.idtiket);
        hasiltgl=findViewById(R.id.tgltrans);
        hasilstatus=findViewById(R.id.statusvalidasi);
        nik=findViewById(R.id.nikktp);
        nama=findViewById(R.id.namacust);
        kelamin=findViewById(R.id.sex);
        alamat=findViewById(R.id.alamatcust);
        tujuan=findViewById(R.id.tujuan);
        harga=findViewById(R.id.hargatiket);
    }
    public void pencarian(View view) {
        idtransaksi=txtId.getText().toString();
        if(TextUtils.isEmpty(idtransaksi))
        {
            AlertDialog.Builder builder=new AlertDialog.Builder(getBaseContext());
            builder.setMessage("MASUKAN ID YANG AKAN DI CARI !");
            builder.setTitle("Ups !");
            builder.setPositiveButton("OK", new DialogInterface.OnClickListener() {
                @Override
                public void onClick(DialogInterface dialog, int which) {
                    txtId.setText("");
                }
            });
            AlertDialog a=builder.create();
            a.show();
        }
        else
            {
        final RequestQueue requestQueue = Volley.newRequestQueue(this);
        final String url="http://192.168.43.136/web_sister/REST_API/api/transaksi?idTransaksi="+idtransaksi;
        JsonObjectRequest jsonObjectRequest = new JsonObjectRequest(Request.Method.GET, url, null, new Response.Listener<JSONObject>() {
            @Override
            public void onResponse(JSONObject response) {
                try {
                    JSONArray responseJSONArray = response.getJSONArray("data");//nama Array
                    for (int i = 0; i < responseJSONArray.length(); i++) {
                        hasilid.setText(responseJSONArray.getJSONObject(i).get("idTransaksi").toString());
                        hasilcus.setText(responseJSONArray.getJSONObject(i).get("idCustomer").toString());
                        hasiltgl.setText(responseJSONArray.getJSONObject(i).get("tglTransaksi").toString());
                        Status=responseJSONArray.getJSONObject(i).get("status").toString();
                        hasiltiket.setText(responseJSONArray.getJSONObject(i).get("idTiket").toString());
                        idCus=hasilcus.getText().toString();
                        idTiket=hasiltiket.getText().toString();
                    }
                    if(Status.equals("1")){
                        hasilstatus.setText("SUDAH DIVALIDASI");}
                    else{
                        hasilstatus.setText("BELUM DIVALIDASI");}

                    getCustomer(idCus);
                    getTiket(idTiket);
                    //statusval.setText(Status);
                    //getCustomer(idCus);
                    //getTujuan(idTiket);
//                            id.setText(formattedResult);
//                            tgl.setText(tanggal);
                    //txtShowTextResult.setText("List of Transaksi \n" + " idTransaksi" + "\t tglTransaksi \n" + formattedResult);
                } catch (JSONException e) {
                    e.printStackTrace();
                }
                //                    findViewById(R.id.progressBar).setVisibility(View.GONE);
            }
        }, new Response.ErrorListener() {
            @Override
            public void onErrorResponse(VolleyError error) {
                Toast.makeText(getBaseContext(),"An Error occured while making the request",Toast.LENGTH_LONG);
            }
        });
        requestQueue.add(jsonObjectRequest); }
    }
    private void getCustomer(String id){

        //id= idCus;
        final ArrayList<String> listnya=new ArrayList<>();
        final RequestQueue requestQueue = Volley.newRequestQueue(this);
        final String url="http://192.168.43.136/web_sister/REST_API/api/pelanggan?idCustomer="+id;
        JsonObjectRequest jsonObjectRequest=new JsonObjectRequest(Request.Method.GET, url, null, new Response.Listener<JSONObject>() {
            @Override
            public void onResponse(JSONObject response) {
                try{
                    JSONArray responseJSONArray = response.getJSONArray("data");
                    for(int i=0;i<responseJSONArray.length();i++){
                        nik.setText(responseJSONArray.getJSONObject(i).get("nik").toString());
                        nama.setText(responseJSONArray.getJSONObject(i).get("namaCustomer").toString());
                        kelamin.setText(responseJSONArray.getJSONObject(i).get("sex").toString());
                        alamat.setText(responseJSONArray.getJSONObject(i).get("alamatCustomer").toString());
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
                AlertDialog.Builder builder=new AlertDialog.Builder(getApplicationContext());
                builder.setMessage(error.toString());
                builder.setTitle("Ups !");
                builder.setPositiveButton("OK", new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialog, int which) {
                        txtId.setText("");
                    }
                });
                AlertDialog a=builder.create();
                a.show();
            }
        });
        requestQueue.add(jsonObjectRequest);
    }

    public void getTiket(String id) {
        //id=idTiket;
        final RequestQueue requestQueue = Volley.newRequestQueue(this);
        final String url="http://192.168.43.136/web_sister/REST_API/api/tiket?idTiket="+id;
        JsonObjectRequest jsonObjectRequest=new JsonObjectRequest(Request.Method.GET, url, null, new Response.Listener<JSONObject>() {
            @Override
            public void onResponse(JSONObject response) {
                try{
                    JSONArray responseJSONArray = response.getJSONArray("data");
                    for(int i=0;i<responseJSONArray.length();i++){
                        tujuan.setText(responseJSONArray.getJSONObject(i).get("tujuan").toString());
                        harga.setText(responseJSONArray.getJSONObject(i).get("harga").toString());
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
                AlertDialog.Builder builder=new AlertDialog.Builder(getApplicationContext());
                builder.setMessage(error.toString());
                builder.setTitle("Ups !");
                builder.setPositiveButton("OK", new DialogInterface.OnClickListener() {
                    @Override
                    public void onClick(DialogInterface dialog, int which) {
                        txtId.setText("");
                    }
                });
                AlertDialog a=builder.create();
                a.show();
            }
        });
        requestQueue.add(jsonObjectRequest);
    }
}
