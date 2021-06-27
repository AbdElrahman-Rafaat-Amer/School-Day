package com.example.schoolday.teacher.assignment;

public class AssignmentYearResponse {
    int yearId;
    String yearName;

    public AssignmentYearResponse(int yearId, String yearName) {
        this.yearId = yearId;
        this.yearName = yearName;
    }

    public AssignmentYearResponse() {
    }

    public int getYearId() {
        return yearId;
    }

    public void setYearId(int yearId) {
        this.yearId = yearId;
    }

    public String getYearName() {
        return yearName;
    }

    public void setYearName(String yearName) {
        this.yearName = yearName;
    }
}
