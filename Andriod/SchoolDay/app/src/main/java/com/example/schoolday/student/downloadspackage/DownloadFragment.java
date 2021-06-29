package com.example.schoolday.student.downloadspackage;

import android.os.Bundle;

import androidx.fragment.app.Fragment;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Toast;

import com.example.schoolday.APIClient;
import com.example.schoolday.R;

import java.util.ArrayList;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class DownloadFragment extends Fragment {

    ArrayList<Downloads> downloads = new ArrayList<>();
    DownloadRecyclerViewAdapter adapter;
    RecyclerView recyclerView;

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {

        View view = inflater.inflate(R.layout.fragment_download, container, false);

        recyclerView = view.findViewById(R.id.recyclerView_download);

        DownloadInterface downloadInterface = APIClient.getRetrofit().create(DownloadInterface.class);
        downloadInterface.getDownload().enqueue(new Callback<ArrayList<Downloads>>() {
            @Override
            public void onResponse(Call<ArrayList<Downloads>> call, Response<ArrayList<Downloads>> response) {
                downloads = response.body();

                adapter = new DownloadRecyclerViewAdapter(getContext(), downloads);
                recyclerView.setLayoutManager(new LinearLayoutManager(getActivity()));
                recyclerView.setAdapter(adapter);
            }

            @Override
            public void onFailure(Call<ArrayList<Downloads>> call, Throwable t) {
                Toast.makeText(getContext(), "There is problem", Toast.LENGTH_SHORT).show();
            }
        });


        return view;
    }
}