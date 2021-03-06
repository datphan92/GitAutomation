import { Observable } from "rxjs";
import { OutputMessage } from "./output-message";

export const remoteBranches = (when: Observable<any>) =>
  when.switchMap(() =>
    Observable.ajax("/api/management/remote-branches").map(
      response => response.response as string[]
    )
  );

export const getLog = (when: Observable<any>) =>
  when.switchMap(() =>
    Observable.ajax("/api/management/log").map(
      response => response.response as OutputMessage[]
    )
  );

export const fetch = (when: Observable<any>) =>
  when.switchMap(() =>
    Observable.ajax
      .post("/api/gitwebhook")
      .map(response => response.response as null)
  );
