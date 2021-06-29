package com.example.schoolday.teacher.assignment;

public class AssignmentTeacherFragmentRequest {
    String startDate;
    String endDate;
    int subjectId;
    int yearId;
    String assignmentName;
    String assignmentPath;
    String assignmentPhoto;

    public AssignmentTeacherFragmentRequest() {
    }

    public AssignmentTeacherFragmentRequest(String startDate, String endDate, int subjectId, int yearId, String assignmentName, String assignmentPath, String assignmentPhoto) {
        this.startDate = startDate;
        this.endDate = endDate;
        this.subjectId = subjectId;
        this.yearId = yearId;
        this.assignmentName = assignmentName;
        this.assignmentPath = assignmentPath;
        this.assignmentPhoto = assignmentPhoto;
    }

    public String getStartDate() {
        return startDate;
    }

    public void setStartDate(String startDate) {
        this.startDate = startDate;
    }

    public String getEndDate() {
        return endDate;
    }

    public void setEndDate(String endDate) {
        this.endDate = endDate;
    }

    public int getSubjectId() {
        return subjectId;
    }

    public void setSubjectId(int subjectId) {
        this.subjectId = subjectId;
    }

    public int getYearId() {
        return yearId;
    }

    public void setYearId(int yearId) {
        this.yearId = yearId;
    }

    public String getAssignmentName() {
        return assignmentName;
    }

    public void setAssignmentName(String assignmentName) {
        this.assignmentName = assignmentName;
    }

    public String getAssignmentPath() {
        return assignmentPath;
    }

    public void setAssignmentPath(String assignmentPath) {
        this.assignmentPath = assignmentPath;
    }

    public String getAssignmentPhoto() {
        return assignmentPhoto;
    }

    public void setAssignmentPhoto(String assignmentPhoto) {
        this.assignmentPhoto = assignmentPhoto;
    }
}
