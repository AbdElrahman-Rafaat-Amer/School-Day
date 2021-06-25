package com.example.schoolday.student.downloadspackage;

public class Downloads {
int subjectId;
String subjectName;
String photoPath;

    public Downloads(int subjectId, String subjectName, String photoPath) {
        this.subjectId = subjectId;
        this.subjectName = subjectName;
        this.photoPath = photoPath;
    }

    public int getSubjectId() {
        return subjectId;
    }

    public void setSubjectId(int subjectId) {
        this.subjectId = subjectId;
    }

    public String getSubjectName() {
        return subjectName;
    }

    public void setSubjectName(String subjectName) {
        this.subjectName = subjectName;
    }

    public String getPhotoPath() {
        return photoPath;
    }

    public void setPhotoPath(String photoPath) {
        this.photoPath = photoPath;
    }
}
