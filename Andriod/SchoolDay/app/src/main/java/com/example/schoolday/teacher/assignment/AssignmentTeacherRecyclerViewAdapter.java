package com.example.schoolday.teacher.assignment;

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

public class AssignmentTeacherRecyclerViewAdapter extends RecyclerView.Adapter<AssignmentTeacherRecyclerViewAdapter.AssignmentTeacherViewHolder> {

    Context context;
    ArrayList<AssignmentTeacher> assignmentTeachers = new ArrayList<AssignmentTeacher>();
    public AssignmentTeacherRecyclerViewAdapter(Context context,ArrayList<AssignmentTeacher> assignmentTeacher){
        this.context = context;
        this.assignmentTeachers = assignmentTeacher;

    }

    @NonNull
    @Override
    public AssignmentTeacherViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        View view = LayoutInflater.from(context).inflate(R.layout.custom_row_assignment_teacher, parent, false);
        AssignmentTeacherViewHolder assignmentTeacherViewHolder = new AssignmentTeacherViewHolder(view);
        return assignmentTeacherViewHolder;
    }

    @Override
    public void onBindViewHolder(@NonNull AssignmentTeacherViewHolder holder, int position) {
        final AssignmentTeacher assignmentTeacher = assignmentTeachers.get(position);
        holder.assignmentTeacher.setBackground(Drawable.createFromPath(assignmentTeacher.photoPath));
        holder.assignmentName.setText(assignmentTeacher.getName());
        holder.assignmentDate.setText((CharSequence) assignmentTeacher.getStartDate());
        holder.assignmentGrade.setText(assignmentTeacher.getYear());
    }

    @Override
    public int getItemCount() {
       return assignmentTeachers.size();
    }

    public class AssignmentTeacherViewHolder extends RecyclerView.ViewHolder{
        ImageView assignmentTeacher;
        TextView assignmentName,assignmentGrade,assignmentDate;

        public AssignmentTeacherViewHolder(@NonNull View itemView) {
            super(itemView);

            assignmentTeacher=itemView.findViewById(R.id.assignment_teacher_image);
            assignmentName = itemView.findViewById(R.id.assignment_teacher_name);
            assignmentGrade = itemView.findViewById(R.id.assignment_teacher_grade);
            assignmentDate = itemView.findViewById(R.id.assignment_teacher_date);
        }
    }

}
