package com.example.schoolday.student.notepackage;

public class    Notes {
    private String title, text, date;
    private int id;

    public Notes() {
        this.title = title;
        this.text = text;
        this.id = id;
        this.date = date;
    }

    public Notes(String title, String text, int id, String date) {

        this.title = title;
        this.text = text;
        this.id = id;
        this.date = date;
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

    public Notes(String title, String text, String date) {
        this.title = title;
        this.text = text;
        this.date = date;
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

    public String getDate() {
        return date;
    }

    public void setDate(String date) {
        this.date = date;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }
}
