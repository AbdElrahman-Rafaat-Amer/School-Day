package com.example.schoolday.parent.feespackage;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.RadioButton;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import com.example.schoolday.R;

import java.util.ArrayList;

public class FeesRecyclerViewAdapter extends RecyclerView.Adapter<FeesRecyclerViewAdapter.FeesViewHolder> {


    Context context;
    ArrayList<Fees> feess = new ArrayList<Fees>();
    public FeesRecyclerViewAdapter(Context context, ArrayList<Fees> fees) {
        this.context = context;
        this.feess = fees;
    }

    @Override
    public FeesViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        View view = LayoutInflater.from(context).inflate(R.layout.custom_row_fees, parent, false);
            FeesViewHolder feesViewHolder = new FeesViewHolder(view);
        return feesViewHolder;
    }

    @Override
    public void onBindViewHolder(@NonNull FeesViewHolder holder, int position) {
     /*   final Fees fees = feess.get(position);
        holder.amount.setText(fees.getAmount());
        holder.studentAdmissions.setText(fees.getName());
        holder.expire.setText(fees.getDate());
        holder.status.setActivated(true);

        holder.cashOut.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

            }
        });


        holder.cashOutAll.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

            }
        });*/
    }

    @Override
    public int getItemCount() {
        return feess.size();
    }

    public class FeesViewHolder extends RecyclerView.ViewHolder {
        TextView amount, studentAdmissions,expire;
       RadioButton status;
       Button cashOut,cashOutAll;

        public FeesViewHolder(@NonNull View itemView) {
            super(itemView);

            amount = itemView.findViewById(R.id.amount);
            studentAdmissions = itemView.findViewById(R.id.studentAdmissions);
            expire = itemView.findViewById(R.id.expire);
            status = itemView.findViewById(R.id.status);
            cashOut = itemView.findViewById(R.id.cashOut);
            cashOutAll = itemView.findViewById(R.id.cashOutAll);





        }
    }}
