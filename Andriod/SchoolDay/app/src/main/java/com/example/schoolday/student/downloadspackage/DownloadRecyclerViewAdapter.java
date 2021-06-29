package com.example.schoolday.student.downloadspackage;

import android.content.Context;
import android.graphics.drawable.Drawable;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import com.example.schoolday.R;

import java.util.ArrayList;

public class DownloadRecyclerViewAdapter extends RecyclerView.Adapter<DownloadRecyclerViewAdapter.DownloadViewHolder> {
    Context context;
    ArrayList<Downloads> download = new ArrayList<Downloads>();

    public DownloadRecyclerViewAdapter(Context context, ArrayList<Downloads> downloads) {
        this.context = context;
        this.download = downloads;
    }

    @NonNull
    @Override
    public DownloadViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        View view = LayoutInflater.from(context).inflate(R.layout.custom_row_download, parent, false);
        DownloadViewHolder downloadViewHolder = new DownloadViewHolder(view);
        return downloadViewHolder;
    }

    @Override
    public void onBindViewHolder(@NonNull DownloadViewHolder holder, int position) {
        final Downloads downloads = download.get(position);
        holder.downloadName.setText(downloads.getSubjectName());
        holder.downlaodImg.setBackground(Drawable.createFromPath(downloads.photoPath));

    }

    @Override
    public int getItemCount() {
        return download.size();
    }

    public class DownloadViewHolder extends RecyclerView.ViewHolder {
        TextView downloadName;
        ImageView downlaodImg;

        public DownloadViewHolder(@NonNull View itemView) {
            super(itemView);


            downloadName = itemView.findViewById(R.id.download_name);
            downlaodImg = itemView.findViewById(R.id.download_img);
        }
    }
}
