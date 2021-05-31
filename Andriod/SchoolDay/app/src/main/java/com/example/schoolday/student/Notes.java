package com.example.schoolday.student;

import java.util.Date;

public class Notes {
    private String title, text;//, dateAndTime;
    private int id;
    private Date dateAndTime;

    public Notes(String title, String text, int id, Date dateAndTime) {
        this.title = title;
        this.text = text;
        this.id = id;
        this.dateAndTime = dateAndTime;
    }

    public Notes(String title, String text, int id) {
        this.title = title;
        this.text = text;
        this.id = id;
    }

    public Notes(String title, String text) {
        this.title = title;
        this.text = text;
    }

    public String getTitle() {
        return title;
    }

    public void setTitle(String title) {
        this.title = title;
    }

    public String getText() {
        return text;
    }

    public void setText(String text) {
        this.text = text;
    }

    public Date getDateAndTime() {
        return dateAndTime;
    }

    public void setDateAndTime(Date dateAndTime) {
        this.dateAndTime = dateAndTime;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }
}
