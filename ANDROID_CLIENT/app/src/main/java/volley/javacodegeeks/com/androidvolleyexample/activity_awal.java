package volley.javacodegeeks.com.androidvolleyexample;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;

public class activity_awal extends Activity {
    public void onCreate(Bundle awalan){
        super.onCreate(awalan);
        setContentView(R.layout.activity_home);
    }

    public void keCekTr(View view) {
        Intent i=new Intent(this,MainActivity.class);
        startActivity(i);
    }

    public void kebooking(View view) {
        Intent i=new Intent(this,activity_booking.class);
        startActivity(i);
    }
}
