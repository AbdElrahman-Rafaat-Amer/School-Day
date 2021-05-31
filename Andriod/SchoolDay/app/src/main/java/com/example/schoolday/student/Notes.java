package com.example.schoolday.student;

import java.util.Date;

public class Notes {
    public void setTitle(String title) {
        this.title = title;
    }

    public void setText(String text) {
        this.text = text;
    }

    public void setId(int id) {
        this.id = id;
    }

    public void setDateAndTime(Date dateAndTime) {
        this.dateAndTime = dateAndTime;
    }

    private String title, text;//, dateAndTime;
    private int id;
    private Date dateAndTime;

    public String getTitle() {
        return title;
    }

    public String getText() {
        return text;
    }

    public Date getDateAndTime() {
        return dateAndTime;
    }

    public int getId() {
        return id;
    }
}
