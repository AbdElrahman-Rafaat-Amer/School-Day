export class posts{
    id:number;
    text:string;
    date:string;
    photos:File[];
    accountid:number;
    like:number;
    image:string;
    username:string;
}

export class createPost{
    text:string;
    photo:FormData;
    accountid:string;
}