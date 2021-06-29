package com.example.schoolday.parent.feespackage;

import android.os.Bundle;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import com.example.schoolday.APIClient;
import com.example.schoolday.R;
import com.example.schoolday.student.MainActivity;
import com.example.schoolday.student.feespackage.Fees;
import com.example.schoolday.student.feespackage.FeesInterface;
import com.example.schoolday.student.feespackage.FeesRecyclerViewAdapter;

import java.util.ArrayList;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class ParentFeesActivity extends AppCompatActivity {

    FeesRecyclerViewAdapter adapter;
    RecyclerView recyclerView;
    ArrayList<Fees> fees = new ArrayList<>();

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_parent_fees);
        recyclerView = findViewById(R.id.recyclerView_fees_parent);

        com.example.schoolday.student.feespackage.FeesInterface FeesInterface = APIClient.getRetrofit().create(com.example.schoolday.student.feespackage.FeesInterface.class);

        FeesInterface.getFees().enqueue(new Callback<ArrayList<Fees>>() {
            @Override
            public void onResponse(Call<ArrayList<Fees>> call, Response<ArrayList<Fees>> response) {
                fees = response.body();

                adapter = new FeesRecyclerViewAdapter(ParentFeesActivity.this,fees);
                recyclerView.setLayoutManager(new LinearLayoutManager(ParentFeesActivity.this));
                recyclerView.setAdapter(adapter);
            }

            @Override
            public void onFailure(Call<ArrayList<Fees>> call, Throwable t) {

                Toast.makeText(ParentFeesActivity.this, "There is problem", Toast.LENGTH_SHORT).show();
            }
        });

    }
}