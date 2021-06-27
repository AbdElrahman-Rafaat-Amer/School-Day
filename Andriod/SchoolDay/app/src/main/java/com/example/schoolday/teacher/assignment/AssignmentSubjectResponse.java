package com.example.schoolday.teacher.assignment;

public class AssignmentSubjectResponse {
    int subjectID;
    String subjectName;

    public AssignmentSubjectResponse(int subjectID, String subjectName) {
        this.subjectID = subjectID;
        this.subjectName = subjectName;
    }

    public AssignmentSubjectResponse() {
    }

    public int getSubjectID() {
        return subjectID;
    }

    public void setSubjectID(int subjectID) {
        this.subjectID = subjectID;
    }

    public String getSubjectName() {
        return subjectName;
    }

    public void setSubjectName(String subjectName) {
        this.subjectName = subjectName;
    }
}
