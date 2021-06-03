package com.example.schoolday.student.feespackage;

import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.fragment.app.Fragment;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import com.example.schoolday.APIClient;
import com.example.schoolday.R;

import java.util.ArrayList;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class FragmentFees extends Fragment {

    FeesRecyclerViewAdapter adapter;
    RecyclerView recyclerView;
    ArrayList<Fees> fees = new ArrayList<>();

    @Override
    public View onCreateView(@NonNull LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {

       View view = inflater.inflate(R.layout.fragment_fees,container,false);
        recyclerView = view.findViewById(R.id.recyclerView_fees);

        FeesInterface FeesInterface = APIClient.getRetrofit().create(FeesInterface.class);

        FeesInterface.getFees().enqueue(new Callback<ArrayList<Fees>>() {
            @Override
            public void onResponse(Call<ArrayList<Fees>> call, Response<ArrayList<Fees>> response) {
                fees = response.body();

                adapter = new FeesRecyclerViewAdapter(getContext(),fees);
                recyclerView.setLayoutManager(new LinearLayoutManager(getActivity()));
                recyclerView.setAdapter(adapter);
            }

            @Override
            public void onFailure(Call<ArrayList<Fees>> call, Throwable t) {

                Toast.makeText(getContext(), "There is problem", Toast.LENGTH_SHORT).show();
            }
        });
        return view;
    }


    }

